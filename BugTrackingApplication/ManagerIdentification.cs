using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingApplication {
    class ManagerIdentification {
        public int managerId;
        public string managerEmail;
        public void getMangerInformation(string email) {
            managerEmail = email;
        }

        public void getId(int id) {
            managerId = id;
        }

    }
}
