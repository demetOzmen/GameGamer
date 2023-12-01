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
    public class CampaignManager: ICampaignService
    {
        ICampaignDal _campaignDal;
        public CampaignManager(ICampaignDal campaignDal)
        {
            _campaignDal = campaignDal;
        }
        public void Add(Campaign campaign)
        {
            _campaignDal.Add(campaign);
        }
        public void Delete(Campaign campaign)
        {
            _campaignDal.Delete(campaign);
        }
        public void Update(Campaign campaign)
        {
            _campaignDal.Update(campaign);
        }
        public List<Campaign> GetList(Campaign campaign)
        {
            return _campaignDal.GetAll();
        }

        public List<Campaign> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
