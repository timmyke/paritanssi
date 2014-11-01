using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Paritanssi.DAL;
using Paritanssi.Models;

namespace Paritanssi.Logic {
    public class Repository<T> where T : IEntity {

        private DatabaseContext _context;

        public Repository() {
            _context = new DatabaseContext();
        } 

        public Repository(DatabaseContext context) {
            _context = context;
        }


        public void Add() {
            
        }

    }
}