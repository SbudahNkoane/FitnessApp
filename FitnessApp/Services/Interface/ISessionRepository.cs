using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Services.Interface
{
    internal interface ISessionRepository
    {
        Task<IEnumerable<Session>> GetSessions();
    }
}
