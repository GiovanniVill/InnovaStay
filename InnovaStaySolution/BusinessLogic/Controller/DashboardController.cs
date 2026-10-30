using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class DashboardController
    {
        private readonly DashboardRepository _repository;

        public DashboardController()
        {
            _repository = new DashboardRepository();
        }

        public DashboardSummary GetFrontDeskDashboardData()
        {
            return _repository.GetFrontDeskSummary();
        }
    }
}