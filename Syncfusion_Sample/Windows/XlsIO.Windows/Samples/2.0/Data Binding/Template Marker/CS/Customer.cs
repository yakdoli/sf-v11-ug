﻿
using System.Drawing;
namespace EssentialXlsIOSamples
{
    class Customer
    {
        #region Members
        private string m_salesPerson;
        private string m_salesJanJune;
        private string m_salesJulyDec;
        private int m_change;
        #endregion

        #region Prperties
        public string SalesPerson
        {
            get
            {
                return m_salesPerson;
            }
            set
            {
                m_salesPerson = value;
            }
        }

        public string SalesJanJune
        {
            get
            {
                return m_salesJanJune;
            }
            set
            {
                m_salesJanJune = value;
            }
        }
        public string SalesJulyDec
        {
            get
            {
                return m_salesJulyDec;
            }
            set
            {
                m_salesJulyDec = value;
            }

        }
        public int Change
        {
            get
            {
                return m_change;
            }
            set
            {
                m_change = value;
            }

        }
        #endregion

        #region Intialization
        public Customer()
        {
        }
        public Customer(string name,string juneToJuly,string julyToDec,int change)
        {
            this.m_salesPerson = name;
            this.m_salesJanJune = juneToJuly;
            this.m_salesJulyDec = julyToDec;
            this.m_change = change;
        }
        #endregion
    }
}
