using System;
using Repo;

namespace MockingPractice
{
    public class AddBusinessLogic
    {
        public static void main()
        {
             int Add()
            {
                AddPoco repo = new AddPoco();
                return repo.Add();
            }
        }
    } }
