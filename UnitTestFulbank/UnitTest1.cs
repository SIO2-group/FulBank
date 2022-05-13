using Fulbank.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fulbank;
using MySql.Data.MySqlClient;
using FulBank;

namespace UnitTestFulbank
{

    // Creation d'un utilisateur de test (non implémenté)
    public class DataLoad
    {
        /*  public static User UserDataLoad()
          {

              FormMain.dbConnexion.Open();

              string salt = BCrypt.Net.BCrypt.GenerateSalt();
              string password = BCrypt.Net.BCrypt.HashPassword("M0tdeP@sse", salt);

              string insertPersonQuery = "INSERT INTO person(P_ID, P_NAME, P_FIRSTNAME, P_PASSWORD) VALUES(-1, TESTNAME,TESTFIRSTNAME,?password)";
              MySqlCommand cmdInsertPerson = new MySqlCommand(insertPersonQuery, FormMain.dbConnexion);
              cmdInsertPerson.Parameters.AddWithValue("password", password);
              cmdInsertPerson.ExecuteNonQuery();

              string insertUserQuery = "INSERT INTO user(U_ID, U_PHONE, U_LANDLINE, U_MAIL, U_ADRESS) VALUES(-1,0625874589,0245152879,testname.firstname@mail.com,56 rue du puit, 28000, Chartres)";
              MySqlCommand cmdInsertUser = new MySqlCommand(insertUserQuery, FormMain.dbConnexion);
              cmdInsertUser.ExecuteNonQuery();

              string insertAccountQuery = "INSERT INTO account(A_ID, A_ID_ACCOUNTTYPE, A_ID_USER, A_BALANCE, A_BALANCE, A_OVERDRAFT_BALANCE) VALUES(-1,1,-1,100, 0),(-2,2,-1,0, 0)";
              MySqlCommand cmdInsertAccount = new MySqlCommand(insertUserQuery, FormMain.dbConnexion);
              cmdInsertUser.ExecuteNonQuery();

              FormMain.dbConnexion.Close();

              User DataLoad()
              {
                  #region user initialisation
                  FormMain.dbConnexion.Open();
                  string commandTextGetUser = "SELECT * FROM person INNER JOIN user ON person.P_ID = user.U_ID WHERE P_ID = ?id_user ";
                  MySqlCommand cmdGetUser = new MySqlCommand(commandTextGetUser, FormMain.dbConnexion);
                  cmdGetUser.Parameters.AddWithValue("id_user", _userId);
                  MySqlDataReader userInfo = cmdGetUser.ExecuteReader();
                  userInfo.Read();
                  User aUser = new User(int.Parse(userInfo["P_ID"].ToString()), userInfo["P_NAME"].ToString(), userInfo["P_FIRSTNAME"].ToString(), userInfo["U_MAIL"].ToString(), userInfo["U_PHONE"].ToString(), userInfo["U_LANDLINE"].ToString(), userInfo["U_ADRESS"].ToString());
                  FormMain.dbConnexion.Close();
                  #endregion
                  #region user accounts load
                  FormMain.dbConnexion.Open();
                  string commandTextTestUser = "SELECT A_ID, A_ID_ACCOUNTTYPE, A_BALANCE, A_OVERDRAFT_LIMIT FROM account WHERE A_ID_USER = ?id_user ";
                  MySqlCommand cmdGetUserAccounts = new MySqlCommand(commandTextTestUser, FormMain.dbConnexion);
                  cmdGetUserAccounts.Parameters.AddWithValue("id_user", -1);
                  MySqlDataReader userAccounts = cmdGetUserAccounts.ExecuteReader();


                  while (userAccounts.Read())
                  {
                      aUser.Add_Account(int.Parse(userAccounts["A_ID"].ToString()), int.Parse(userAccounts["A_ID_ACCOUNTTYPE"].ToString()), double.Parse(userAccounts["A_BALANCE"].ToString().Replace(".", ",")), int.Parse(userAccounts["A_OVERDRAFT_LIMIT"].ToString()));
                  }

                  FormMain.dbConnexion.Close();

                  #endregion
                  #region user accounts operation load
                  Account accounts = aUser.GetAccounts()[0];
                  FormMain.dbConnexion.Open();
                  string commandTextoperation = "SELECT OP_ID, OP_AMOUNT, OP_ISDEBIT, DATE_FORMAT(OP_DATE,'%d-%m-%Y %H:%i:%s') as OP_DATE FROM account INNER JOIN operation ON account.A_ID = operation.OP_ID_ACCOUNT WHERE OP_ID_ACCOUNT = ?id_account ORDER BY OP_ID DESC";
                  MySqlCommand cmdGetoperation = new MySqlCommand(commandTextoperation, FormMain.dbConnexion);
                  cmdGetoperation.Parameters.AddWithValue("id_account", accounts.Get_Id());

                  MySqlDataReader operation = cmdGetoperation.ExecuteReader();
                  while (operation.Read())
                  {
                      DateTime dt = DateTime.Parse(operation["OP_DATE"].ToString());
                      accounts.Add_Operation(int.Parse(operation["OP_ID"].ToString()), double.Parse(operation["OP_AMOUNT"].ToString()), Convert.ToBoolean(operation["OP_ISDEBIT"].ToString()), dt);
                  }
                  FormMain.dbConnexion.Close();

                  #endregion
                  #region user transation beneficiaries load
                  FormMain.dbConnexion.Open();
                  string commandTextSelectBeneficiary = "SELECT * FROM beneficiary WHERE B_USER_ID = ?id_user";
                  MySqlCommand cmdSelectBeneficiary = new MySqlCommand(commandTextSelectBeneficiary, FormMain.dbConnexion);
                  cmdSelectBeneficiary.Parameters.AddWithValue("id_user", -1);
                  MySqlDataReader userBeneficiaries = cmdSelectBeneficiary.ExecuteReader();


                  while (userBeneficiaries.Read())
                  {
                      aUser.Add_Beneficiary(int.Parse(userBeneficiaries["B_ACCOUNT_ID"].ToString()), userBeneficiaries["B_NAME"].ToString(), int.Parse(_userId));
                  }

                  FormMain.dbConnexion.Close();
                  #endregion
                  #region user cryptowallets load
                  FormMain.dbConnexion.Open();

                  string commandTextSelectWallets = "SELECT * FROM cryptowallet WHERE CW_UID = ?id_user";
                  MySqlCommand cmdSelectWallets = new MySqlCommand(commandTextSelectWallets, FormMain.dbConnexion);
                  cmdSelectWallets.Parameters.AddWithValue("id_user", -1);
                  MySqlDataReader Wallets = cmdSelectWallets.ExecuteReader();

                  while (Wallets.Read())
                  {
                      //while (crypto_op.Read())
                      aUser.AddWallet(int.Parse(Wallets["CW_ID"].ToString()), Wallets["CW_C_SYMBOL"].ToString(), float.Parse(Wallets["CW_AMOUNT"].ToString()));
                  }

                  FormMain.dbConnexion.Close();
                  FormMain.dbConnexion.Open();

                  string commandTextSelectOp = @"SELECT *
                                              FROM crypto_trade
                                              WHERE WALLET_ID = ?id";
                  MySqlCommand cmdSelectOp = new MySqlCommand(commandTextSelectOp, FormMain.dbConnexion);
                  cmdSelectOp.Parameters.AddWithValue("id", -1);
                  MySqlDataReader crypto_op = cmdSelectOp.ExecuteReader();

                  FormMain.dbConnexion.Close();

                  #endregion
                  #region add transfers
                  FormMain.dbConnexion.Open();
                  string commandTextSelectTransfer = @"SELECT T_ID_ACCOUNT_FROM, T_ID_ACCOUNT_TO, T_AMOUNT, DATE_FORMAT(T_DATE,'%d-%m-%Y %H:%i:%s') as T_DATE
                                              FROM transaction
                                              WHERE T_ID_ACCOUNT_FROM IN(SELECT A_ID
                                                                          FROM account
                                                                          WHERE A_ID_USER = ?id_user)";
                  MySqlCommand cmdSelectTransfer = new MySqlCommand(commandTextSelectTransfer, FormMain.FormMain.dbConnexion);
                  cmdSelectTransfer.Parameters.AddWithValue("id_user", aUser.Get_Id());
                  MySqlDataReader transfers = cmdSelectTransfer.ExecuteReader();
                  while (transfers.Read())
                  {
                      Account AccountFrom = new Account();
                      Account AccountTo = new Account();
                      Beneficiary BeneficiaryTo = new Beneficiary();
                      foreach (Account account in aUser.GetAccounts())
                      {
                          if (account.Get_Id() == int.Parse(transfers["T_ID_ACCOUNT_FROM"].ToString()))
                          {
                              AccountFrom = account;
                          }
                      }
                      foreach (Account account in aUser.GetAccounts())
                      {
                          if (account.Get_Id() == int.Parse(transfers["T_ID_ACCOUNT_TO"].ToString()))
                          {
                              AccountTo = account;
                              DateTime dt = DateTime.Parse(transfers["T_DATE"].ToString());
                              aUser.add_Transfer(double.Parse(transfers["T_AMOUNT"].ToString()), dt, AccountFrom, AccountTo);
                          }
                      }
                      foreach (Beneficiary beneficiary in aUser.GetBeneficiary())
                      {
                          if (beneficiary.getBeneficiaryId() == int.Parse(transfers["T_ID_ACCOUNT_TO"].ToString()))
                          {
                              BeneficiaryTo = beneficiary;
                              DateTime dt = DateTime.Parse(transfers["T_DATE"].ToString());
                              aUser.add_TransferToBeneficiary(double.Parse(transfers["T_AMOUNT"].ToString()), dt, AccountFrom, AccountTo, BeneficiaryTo);
                          }
                      }
                  }
                  FormMain.dbConnexion.Close();
                  return aUser;
                  #endregion
              }

              return aUser;
          }
      }


      [TestClass]
      public class BankTest
      {
          [TestMethod]
          public void CreditTest()
          {
              User aUser = DataLoad.UserDataLoad();

              aUser.GetAccounts()[0].OperationCredit(100);

              Assert.AreEqual(200.00, aUser.GetAccounts()[0].Get_Balance());
          }

          [TestMethod]
          public void DebitTest()
          {
              User aUser = DataLoad.UserDataLoad();

              aUser.GetAccounts()[0].OperationDebit(100);

              Assert.AreEqual(0.00, aUser.GetAccounts()[0].Get_Balance());
          }
      }
        */
    }
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void DebitTest()
        {
            User aUser = new User(1, "DE LOS RIOS", "Nathan", "nathan.delosrios28@gmail.com", "0628745324", "0215458965", "3 rue de la pie, 28000, Chartres");
            aUser.Add_Account(1, 1, 500.00, -100);

            aUser.GetAccounts()[0].OperationDebit(100);

            Assert.AreEqual(400.00, aUser.GetAccounts()[0].Get_Balance());
        }

        [TestMethod]
        public void CreditTest()
        {
            User aUser = new User(1, "DE LOS RIOS", "Nathan", "nathan.delosrios28@gmail.com", "0628745324", "0215458965", "3 rue de la pie, 28000, Chartres");
            aUser.Add_Account(1, 1, 500.00, -100);

            aUser.GetAccounts()[0].OperationCredit(100);

            Assert.AreEqual(600.00, aUser.GetAccounts()[0].Get_Balance());
        }
    }

}
