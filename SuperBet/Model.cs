using SuperBet.DatabaseCommunication;
using System.Text.RegularExpressions;
using Windows.Devices.Power;

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
        private Addict _loggedInUser = null;
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
            var rand = new Random();
            int id = rand.Next(_idRange);
            while (_usedIds.Contains(id))
            {
                id = rand.Next(_idRange);
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
            if (user.Result == null || user.Result.Password != password) {
                return false;
            }
            _loggedInUser = user.Result;
            return true;
        }
    }
}
