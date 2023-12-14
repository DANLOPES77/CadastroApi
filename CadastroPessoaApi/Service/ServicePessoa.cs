﻿using CADASTROPESSOAAPI.DATA;
using CADASTROPESSOAAPI.VIEWMODEL;
using Microsoft.AspNetCore.Http.HttpResults;
 
namespace CADASTROPESSOAAPI.SERVICE
{
    public class SERVICEPESSOA
    {
        private int PESSOAID;
 
        public IEnumerable<PESSOAVIEWMODEL> getall()
        {
            var repository = new REPOSITORY();
            return repository.GETALL().ToList();
        }
        public PESSOAVIEWMODEL GetByid(int pessoaid)
 
        {
            var repository = new REPOSITORY();
            return repository.GetByid(pessoaid);
 
 
        }
        public void Update(int pessoaId, string primeiroNome)
        {
            //pessoa = 2 && primeiro =="israel"
            //pessoaid = -1 && primeironome == "Israel"
            //pessoa == 0 && primeironome= ""
            //pessoa== 3 && primeironome = null
 
            if (PESSOAID > 0 && !string.IsNullOrEmpty(primeiroNome))
            {
                var repository = new REPOSITORY();
                repository.Update(pessoaId, primeiroNome);
             }
        }