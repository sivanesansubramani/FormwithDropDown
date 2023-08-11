using FormwithDropDown.Models;



namespace FormwithDropDown.Repository
{
    public class BioRepository
    {



        public readonly string connectionString;


        public BioRepository()
        {

            connectionString = @"Data Source = DESKTOP-21TGVVO; Initial Catalog = DropDown; Integrated Security = True";
        }

        /*public BioModel DynamicDataModel()
        {
            BioModel ObjPersonalBio = new BioModel();

            Console.WriteLine("enter id");
            ObjPersonalBio.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter fist name");
            ObjPersonalBio.Name = Console.ReadLine();

            Console.WriteLine("enter your last name name");
            ObjPersonalBio.LastName = Console.ReadLine();

            Console.WriteLine("enter age");
            ObjPersonalBio.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter address");
            ObjPersonalBio.Address = Console.ReadLine();


            return ObjPersonalBio;
        }*/


        public void InsertPersonalData(BioModel bio)
        {
            try
            {

                SqlConnection connectionObject = new SqlConnection(connectionString);

                connectionObject.Open();
                connectionObject.Execute($"exec InsertPersonalBio '{bio.Name}', '{bio.Gender}','{bio.Location}' ");


                connectionObject.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<BioModel> Select()

        {
            try
            {
                List<BioModel> ListofPersonalData = new List<BioModel>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                ListofPersonalData = connection.Query<BioModel>("exec SelectPersonalBio", connectionString).ToList();
                connection.Close();



                return ListofPersonalData;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }








        public void ubdate(BioModel bio)
        {
            try
            {
                SqlConnection connectionObject = new SqlConnection(connectionString);



                connectionObject.Open(); // Age = @Age, Address = @Address where id = @id

                connectionObject.Execute($"  exec UbdatePersonalBio '{bio.Name}','{bio.Gender}','{bio.Location}','{bio.id}' ");


                connectionObject.Close();
            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void delete(int Id)
        {
            try
            {
                SqlConnection connectionObject = new SqlConnection(connectionString);

                /* Console.WriteLine("enter a id  to delete record");
                 int del = Convert.ToInt32(Console.ReadLine());
 */
                connectionObject.Open();
                connectionObject.Execute($"exec DeletePersonalBio {Id} ");


                connectionObject.Close();
            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public BioModel SelectSP(int id)
        {
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                var res = connection.QueryFirst<BioModel>($"exec selects {id}");
                connection.Close();

                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
