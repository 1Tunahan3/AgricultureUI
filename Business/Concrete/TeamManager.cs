﻿using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TeamManager : ITeamService
    {
        ITeamDal _teamDal;
        public TeamManager(ITeamDal teamDal)
        {
            this._teamDal = teamDal;
        }

        public void AddT(Team entity)
        {
            _teamDal.AddT(entity);
        }

        public void Delete(Team entity)
        {
            _teamDal.Delete(entity);
        }

        public List<Team> GetAll()
        {
            return _teamDal.GetAll();
        }

        public Team GetById(int id)
        {
            return _teamDal.GetById(id);
        }

        public void Update(Team entity)
        {
            _teamDal.Update(entity);
        }
    }
}
