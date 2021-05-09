using SchoolManagement.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Infrastructure.Services
{
    public interface IRegistrationRequestService
    {
        bool Add(RequestInputModel input);
        List<RequestViewModel> GetPendingRequests(int pageSize, int pageNumber);
        RequestViewModel GetById(int id);
        void UpdateStatus(int id, bool approved);
        int GetPendingRequestsCount();
    }
}
