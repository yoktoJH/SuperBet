using SuperBet.DatabaseCommunication;
using System.Text.RegularExpressions;

namespace SuperBet
{
    public class Model
    {
        private readonly AddictDAO _addictDAO;
        private readonly TicketDAO _ticketDAO;
        private readonly OddsDAO _oddsDAO;
        private readonly HashSet<int> _usedIds;
        private readonly int _idRange = 100000;
        private readonly Regex _emailRegex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
        private readonly Regex _nameRegex = new Regex(@"^[A-Z]([a-zA-Z])*$");
        private readonly Random random = new Random();
        private Addict? _loggedInUser = null;

        public List<Odds> OddsToShow { get; private set; } = new List<Odds>();

        public Model(SuperBetDb database)
        {
            _addictDAO = new AddictDAO(database);
            _ticketDAO = new TicketDAO(database);
            _oddsDAO = new OddsDAO(database);

            _usedIds = _addictDAO.GetAllAddictsAsync().Result.Select(a => a.Id).ToHashSet();
        }

        public bool AddictExists(string email)
        {
            var result = _addictDAO.GetAddictByEmailAsync(email);
            return result.Result != null;
        }

        public async Task<bool> RegisterAddict(string name, string email, string password)
        {
            var existingAddict = _addictDAO.GetAddictByEmailAsync(email);
            
            int id = random.Next(_idRange);
            while (_usedIds.Contains(id))
            {
                id = random.Next(_idRange);
            }
            _usedIds.Add(id);
            Addict newAddict = new()
            {
                Id = id,
                Name = name,
                Email = email,
                Password = password,
                Admin = false,
                Balance = 1000,
            };

            if (await existingAddict != null)
            {
                return false;
            }
            await _addictDAO.AddAddictAsync(newAddict);
            return true;
        }

        public bool IsValidEmail(string email)
        {
            return _emailRegex.IsMatch(email);
        }

        public bool IsValidName(string name)
        {
            return _nameRegex.IsMatch(name);
        }

        public bool LoginUser(string username, string password)
        {
            var user = _addictDAO.GetAddictByEmailAsync(username);
            if (user.Result == null || user.Result.Password != password)
            {
                return false;
            }
            _loggedInUser = user.Result;
            return true;
        }

        public void LogoutUser()
        {
            _loggedInUser = null;
        }

        public string[] OddsCategories() => _oddsDAO.GetAllAsync().Result.Select(a => a.Category).Distinct().Where(a => a != null).ToArray();

        public void ShowOddsInCategories(string category)
        {
            OddsToShow.AddRange(_oddsDAO.GetByCategory(category,true).Result);
        }


        public void onetimeinsertdata()
        {
            var date = DateTime.Today;
            date.AddDays(8);
            List<Odds> pppp = new() {
                new Odds { OddID = 0, Category = "Madarsko", CloseTime = date, Name = "Sfdfd USA", Description = "Slovensko neprestane hrať v 3. tretine", Rate = 1.001 },
                new Odds { OddID = 0, Category = "Basketbal", CloseTime = date, Name = "Slovensko vs USA", Description = "Slovensko neprestane hrať v 3. tretine", Rate = 1.001 },

            };
            foreach (var item in pppp)
            {
                var x = _oddsDAO.AddAsync(item);
            }
            
        }


        public async void CreateTicket(int oddindex, double value)
        {
            if (_loggedInUser == null) {
                throw new InvalidOperationException("Cannot create tickets without user");
            }
            int id = random.Next(_idRange);
            while (_ticketDAO.GetByIdAsync(id).Result != null)
            {
                id = random.Next(_idRange);
            }
            await _ticketDAO.AddAsync(new Ticket { OddID = OddsToShow[oddindex].OddID, Id = _loggedInUser.Id, TicketId = id, Value = value });
        }

        public List<Ticket> GetUsersTickets()
        {
            if (_loggedInUser == null)
            {
                throw new InvalidOperationException("user not logged in ");
            }
            var x = _ticketDAO.GetAllAsync().Result;
            return _ticketDAO.GetByAllAddictAsync(_loggedInUser.Id).Result;
        }
    }
}
