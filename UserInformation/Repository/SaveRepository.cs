using Microsoft.EntityFrameworkCore;
using UserInformation.Models;
using UserInformation.Repository.Interface;

namespace UserInformation.Repository
{
    public class SaveRepository:ISave
    {
        private readonly AppDbContext dBContext;
        public SaveRepository(AppDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public void Save()
        {
            dBContext.SaveChanges();
        }
    }
}
