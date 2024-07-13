using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace session.Encapsulation
{
    internal struct Phonebook
    {
        #region attributes
        private string[] Names;
        private int[] Numbers;
        #endregion
        #region property
        public int Size { get; } //read only property

        #endregion
        #region Constructor
        public Phonebook(int size)
        {
            Size = size;
            Names = new string[size];
            Numbers = new int[size];

        }
        #endregion
        #region Methods
        public void AddPerson(int position, string PersonName, int PhoneNumbers)
        {
            if (Names is not null && Numbers is not null)
            {
                if (position < Size)
                {
                    Names[position] = PersonName;
                    Numbers[position] = PhoneNumbers;
                }
            }




        }
        #endregion
        #region gettr setter
        public int GetPersonNumber(string PersonName)
        {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Names[i] == PersonName)
                    {
                        return Numbers[i];
                    }
                }
            }
            return -1;
        }
        //setter
        public void SetPersonNumber(string PersonName, int newnumber)
        {
            if (PersonName is not null && Numbers is not null)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Names[i] == PersonName)
                    {

                        Numbers[i] = newnumber;
                        break;
                    }
                }
            }
 


        }

        #endregion
        #region indexer
        //special property 
        //named with keyword this
        //can take parameter
        //
        public int this[string name]
        {
            get
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Names.Length; i++)
                    {
                        if (Names[i] == name)
                        {
                            return Numbers[i];
                        }
                    }
                }
                return -1;

            }
            set
            {
                if (name is not null && Numbers is not null)
                {
                    for (int i = 0; i < Names.Length; i++)
                    {
                        if (Names[i] == name)
                        {

                            Numbers[i] =value ;
                            break;
                        }
                    }
                }
            }
        }

        //0::"ali::4545
        //indexre overloading
        public string this[int index]
        {
            get
            {
                return $"{index}::{Names[index]}::{Numbers[index]}";
            }

        }

        #endregion
    }
}
