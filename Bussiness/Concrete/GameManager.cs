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
    public class GameManager :IGameService
    {
        IGameDal _gameDal;
        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }
        public void Add (Game game)
        {
            _gameDal.Add (game);
        }
        public void Delete (Game game) 
        {
            _gameDal.Delete (game);
        }
        public void Update (Game game)
        {
            _gameDal.Update (game);
        }
        public List<Game> GetList (Game game)
        {
            return _gameDal.GetAll();
        }

        public List<Game> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
