using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegation.Core.Models
{
    public class Role : CoreEntity
    {
        private readonly List<User> _usersInRole = new List<User>();

        public string Name { get; set; }
        public IEnumerable<User> UsersInRole => _usersInRole.AsReadOnly();

        public void AddUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            if (_usersInRole.Any(u => u.Id == user.Id))
                return;

            _usersInRole.Add(user);
        }

        public void RemoveUser(User user)
        {
            var foundUser = _usersInRole.FirstOrDefault(u => u.Id == user.Id);

            if (foundUser == null)
                return;

            _usersInRole.Remove(foundUser);
        }
    }
}
