using GigCommunity.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigCommunity.Core.Repositories
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetFutureAttendances(string userId);
        Attendance GetAttendance(int gigId, string userId);
        void Add(Attendance attendance);
        void Remove(Attendance attendance);
    }
}
