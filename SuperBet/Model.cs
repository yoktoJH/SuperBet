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
        public bool IsAdmin
        {
            get
            {
                if (_loggedInUser != null)
                {
                    return _loggedInUser.Admin;
                }
                return false;
            }
        }

        public List<Odds> OddsToShow { get; private set; } = new List<Odds>();

        public Model(SuperBetDb database)
        {
            _addictDAO = new AddictDAO(database);
            _ticketDAO = new TicketDAO(database);
            _oddsDAO = new OddsDAO(database);
     
            _usedIds = _addictDAO.GetAllAddictsAsync().Result.Select(a => a.Id).ToHashSet();

            //RegisterAdminAddict("ja", "jh@mail.com", "Heslo123").Wait();
        }

        public bool AddictExists(string email)
        {
            var result = _addictDAO.GetAddictByEmailAsync(email);
            return result.Result != null;
        }


        public async Task<bool> RegisterAdminAddict(string name, string email, string password)
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
                Admin = true,
                Balance = 1000,
            };

            if (await existingAddict != null)
            {
                return false;
            }
            await _addictDAO.AddAddictAsync(newAddict);
            return true;
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
        public void ShowOddsInCategoriesAdmin(string category)
        {
            OddsToShow.AddRange(_oddsDAO.GetByCategory(category, false).Result);
        }

        public void onetimeinsertdata()
        {
            var date = DateTime.Today;
            date.AddDays(8);
            List<Odds> pppp = new() {
                new Odds { OddID = 0, Category = "Football", CloseTime = DateTime.Now.AddDays(1), Name = "Manchester United vs Chelsea", Description = "Manchester United won 3-2", Rate = 1.5 },
new Odds { OddID = 0, Category = "Basketball", CloseTime = DateTime.Now.AddDays(2), Name = "Lakers vs Celtics", Description = "Lakers won 102-98", Rate = 2.1 },
new Odds { OddID = 0, Category = "Tennis", CloseTime = DateTime.Now.AddDays(3), Name = "Nadal vs Federer", Description = "Nadal won 3-1", Rate = 1.8 },
new Odds { OddID = 0, Category = "Cricket", CloseTime = DateTime.Now.AddDays(4), Name = "India vs Australia", Description = "India won by 5 wickets", Rate = 2.2 },
new Odds { OddID = 0, Category = "Rugby", CloseTime = DateTime.Now.AddDays(5), Name = "New Zealand vs South Africa", Description = "New Zealand won 15-10", Rate = 1.9 },
new Odds { OddID = 0, Category = "Baseball", CloseTime = DateTime.Now.AddDays(6), Name = "Yankees vs Red Sox", Description = "Yankees won 5-3", Rate = 2.0 },
new Odds { OddID = 0, Category = "Golf", CloseTime = DateTime.Now.AddDays(7), Name = "Woods vs McIlroy", Description = "Woods won by 2 strokes", Rate = 1.7 },
new Odds { OddID = 0, Category = "Boxing", CloseTime = DateTime.Now.AddDays(8), Name = "Mayweather vs Pacquiao", Description = "Mayweather won by KO", Rate = 2.3 },
new Odds { OddID = 0, Category = "Hockey", CloseTime = DateTime.Now.AddDays(9), Name = "Blackhawks vs Bruins", Description = "Blackhawks won 4-2", Rate = 1.6 },
new Odds { OddID = 0, Category = "Soccer", CloseTime = DateTime.Now.AddDays(10), Name = "Barcelona vs Real Madrid", Description = "Barcelona won 2-1", Rate = 2.4 },
new Odds { OddID = 0, Category = "Football", CloseTime = DateTime.Now.AddDays(11), Name = "Arsenal vs Liverpool", Description = "Arsenal won 1-0", Rate = 1.5 },
new Odds { OddID = 0, Category = "Basketball", CloseTime = DateTime.Now.AddDays(12), Name = "Warriors vs Nets", Description = "Warriors won 105-100", Rate = 2.1 },
new Odds { OddID = 0, Category = "Tennis", CloseTime = DateTime.Now.AddDays(13), Name = "Djokovic vs Thiem", Description = "Djokovic won 3-2", Rate = 1.8 },
new Odds { OddID = 0, Category = "Cricket", CloseTime = DateTime.Now.AddDays(14), Name = "England vs West Indies", Description = "England won by 7 wickets", Rate = 2.2 },
new Odds { OddID = 0, Category = "Rugby", CloseTime = DateTime.Now.AddDays(15), Name = "Australia vs England", Description = "Australia won 18-12", Rate = 1.9 },
new Odds { OddID = 0, Category = "Baseball", CloseTime = DateTime.Now.AddDays(16), Name = "Dodgers vs Giants", Description = "Dodgers won 6-4", Rate = 2.0 },
new Odds { OddID = 0, Category = "Golf", CloseTime = DateTime.Now.AddDays(17), Name = "Johnson vs Spieth", Description = "Johnson won by 3 strokes", Rate = 1.7 },
new Odds { OddID = 0, Category = "Boxing", CloseTime = DateTime.Now.AddDays(18), Name = "Canelo vs Golovkin", Description = "Canelo won by decision", Rate = 2.3 },
new Odds { OddID = 0, Category = "Hockey", CloseTime = DateTime.Now.AddDays(19), Name = "Rangers vs Penguins", Description = "Rangers won 3-1", Rate = 1.6 },
new Odds { OddID = 0, Category = "Soccer", CloseTime = DateTime.Now.AddDays(20), Name = "Juventus vs Inter Milan", Description = "Juventus won 2-0", Rate = 2.4 }

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

        public List<Ticket> GetTickets()
        {
          
            return _ticketDAO.GetAllAsync().Result;
            
        }

        public async void UpdateOdds(Odds odds)
        {
           await _oddsDAO.UpdateAsync(odds);
        }

        public async void AddOdds(Odds odds)
        {
            await _oddsDAO.AddAsync(odds);
        }
    }
}
