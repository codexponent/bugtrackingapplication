using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingApplication {
    class RouteInformation {
        private string currentRoute;
        private List<string> routeList = new List<string>();
        public void getRouteList(string routeInfo) {
            routeList.Add(routeInfo);
            currentRoute = routeInfo;
        }
    }
}
