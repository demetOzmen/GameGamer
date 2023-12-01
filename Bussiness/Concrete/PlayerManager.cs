using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IPlayerDal _playerDal;
        public PlayerManager(IPlayerDal playerDal)
        {
            _playerDal = playerDal;
        }
        public string Add(Player player)
        {

            _playerDal.Add(player);
            return "kullanıcı eklendi";

        }
        public bool Delete(Player player)
        {
            _playerDal.Delete(player);
            return true;
        }
        public void Update(Player player)
        {
            _playerDal.Update(player);

        }

        public List<Player> GetList()
        {
            return _playerDal.GetAll();
        }
    }
}
