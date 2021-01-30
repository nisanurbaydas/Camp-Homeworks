using System;
using Camp_Homeworks.Entities;
using Camp_Homeworks.Managers;

namespace Camp_Homeworks
{
    class Program
    {
        public static GamerManager gamerManager = new GamerManager();
        public static GameManager gameManager = new GameManager();
        public static CampaignManager campaignManager = new CampaignManager();
        public static SaleManager saleManager = new SaleManager();

        static void Main(string[] args)
        {
            Console.WriteLine("Choose a menu");
            while (true)
            {
                string menu = "";
                Console.WriteLine("1- Gamer");
                Console.WriteLine("2- Game");
                Console.WriteLine("3- Campaign");
                Console.WriteLine("4- Sale");
                menu = Console.ReadLine();


                switch (Int32.Parse(menu))
                {
                    case 1:
                        GamerMenu();
                        break;
                    case 2:
                        GameMenu();
                        break;
                    case 3:
                        CampaignMenu();
                        break;
                    case 4:
                        SaleMenu();
                        break;
                    default:
                        break;
                }
            }
        }

        static void GamerMenu()
        {
            Console.Clear();
            string menu = "";
            Console.WriteLine("Gamer Menu");
            Console.WriteLine("Choose the action that you want to do: ");
            Console.WriteLine("1- Add");
            Console.WriteLine("2- Update");
            Console.WriteLine("3- Delete");
            Console.WriteLine("4- List");
            menu = Console.ReadLine();


            switch (Int32.Parse(menu))
            {
                case 1:
                    GamerAdd();
                    break;
                case 2:
                    GamerUpdate();
                    break;
                case 3:
                    GamerDelete();
                    break;
                case 4:
                    ListGamers();
                    break;
                default:
                    break;
            }


        }
        static void GameMenu()
        {
            Console.Clear();
            string menu = "";
            Console.WriteLine("Game Menu");
            Console.WriteLine("Choose the action that you want to do: ");
            Console.WriteLine("1- Add");
            Console.WriteLine("2- Delete");
            Console.WriteLine("3- List");
            menu = Console.ReadLine();


            switch (Int32.Parse(menu))
            {
                case 1:
                    GameAdd();
                    break;
                case 2:
                    GameDelete();
                    break;
                case 3:
                    ListGames();
                    break;
                default:
                    break;
            }
        }

        static void CampaignMenu()
        {
            Console.Clear();
            string menu = "";
            Console.WriteLine("Campaign Menu");
            Console.WriteLine("Choose the action that you want to do: ");
            Console.WriteLine("1- Add");
            Console.WriteLine("2- Update");
            Console.WriteLine("3- Delete");
            Console.WriteLine("4- List");
            menu = Console.ReadLine();


            switch (Int32.Parse(menu))
            {
                case 1:
                    CampaignAdd();
                    break;
                case 2:
                    CampaignUpdate();
                    break;
                case 3:
                    CampaignDelete();
                    break;
                case 4:
                    ListCampaign();
                    break;
                default:
                    break;
            }
        }

        static void SaleMenu()
        {
            Console.Clear();
            string menu = "";
            Console.WriteLine("Sales Menu");
            Console.WriteLine("Choose the action that you want to do: ");
            Console.WriteLine("1- Add");
            Console.WriteLine("2- List");
            menu = Console.ReadLine();


            switch (Int32.Parse(menu))
            {
                case 1:
                    SaleAdd();
                    break;
                case 2:
                    ListSales();
                    break;
                default:
                    break;
            }
        }

        static void GamerAdd()
        {
            Gamer gamer = new Gamer();

            Console.WriteLine("Gamer's Id: ");
            gamer.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First Name: ");
            gamer.firstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            gamer.surName = Console.ReadLine();

            Console.WriteLine("Nationality Id: ");
            gamer.nationalityId = Console.ReadLine();

            Console.WriteLine("Birth Year");
            gamer.birthYear = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            gamerManager.Add(gamer);
            Console.ReadKey();
            Console.Clear();
        }

        static void GamerUpdate()
        {
            Console.WriteLine("Enter Gamer Id that you want to update: ");
            int id = -1;
            id = Convert.ToInt32(Console.ReadLine());

            Gamer oldGamer = gamerManager.GetGamer(id);


            Gamer gamer = new Gamer();

            Console.WriteLine("Gamer Id: ");
            gamer.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First Name: ");
            gamer.firstName = Console.ReadLine();

            Console.WriteLine("Sur Name: ");
            gamer.surName = Console.ReadLine();

            Console.WriteLine("Nationality Id: ");
            gamer.nationalityId = Console.ReadLine();

            Console.WriteLine("Birth Year: ");
            gamer.birthYear = Convert.ToInt32(Console.ReadLine());


            Console.Clear();
            gamerManager.Update(oldGamer, gamer);
            Console.ReadKey();
            Console.Clear();
        }

        static void GamerDelete()
        {
            Console.WriteLine("Enter Gamer Id that you want delete: ");
            int id = -1;
            id = Convert.ToInt32(Console.ReadLine());

            Gamer gamer = gamerManager.GetGamer(id);
            Console.Clear();
            gamerManager.Delete(gamer);
            Console.ReadKey();
            Console.Clear();
        }

        static void ListGamers()
        {
            gamerManager.listGamers();
        }

        static void GameAdd()
        {
            Game game = new Game();

            Console.WriteLine("Game Id: ");
            game.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name: ");
            game.name = Console.ReadLine();

            Console.WriteLine("Price: ");
            game.price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Stock: ");
            game.stock = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            gameManager.Add(game);
            Console.ReadKey();
            Console.Clear();
        }

        static void GameDelete()
        {
            Console.WriteLine("Enter Game Id that you want delete: ");
            int id = -1;
            id = Convert.ToInt32(Console.ReadLine());

            Game game = gameManager.GetGame(id);
            Console.Clear();
            gameManager.Delete(game);
            Console.ReadKey();
            Console.Clear();
        }

        static void ListGames()
        {
            gameManager.ListAllGames();
        }

        static void CampaignAdd()
        {
            Campaign campaign = new Campaign();

            Console.WriteLine("Campaign Id: ");
            campaign.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Campaign Name: ");
            campaign.name = Console.ReadLine();

            Console.WriteLine("Discount rate: ");
            campaign.discountRate = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            campaignManager.Add(campaign);
            Console.ReadKey();
            Console.Clear();
        }

        static void CampaignUpdate()
        {
            Console.WriteLine("Enter Campaign Id that you want to update: ");
            int id = -1;
            id = Convert.ToInt32(Console.ReadLine());

            Campaign oldCampaign = campaignManager.getCampaign(id);


            Campaign campaign = new Campaign();

            Console.WriteLine("Campaign Id: ");
            campaign.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Campaign Name: ");
            campaign.name = Console.ReadLine();

            Console.WriteLine("Discount rate: ");
            campaign.discountRate = Convert.ToDouble(Console.ReadLine());


            Console.Clear();
            campaignManager.Update(oldCampaign, campaign);
            Console.ReadKey();
            Console.Clear();
        }

        static void CampaignDelete()
        {
            Console.WriteLine("Enter Campaign Id that you want delete: ");
            int id = -1;
            id = Convert.ToInt32(Console.ReadLine());

            Campaign campaign = campaignManager.getCampaign(id);
            Console.Clear();
            campaignManager.Delete(campaign);
            Console.ReadKey();
            Console.Clear();
        }

        static void ListCampaign()
        {
            campaignManager.ListAll();
        }

        static void SaleAdd()
        {
            Sales sale = new Sales();

            Console.WriteLine("Sale Id: ");
            sale.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Game Id: ");
            sale.gameId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gamer Id: ");
            sale.gamerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Campaign Id: ");
            sale.campaignId = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            saleManager.Add(sale);
            Console.ReadKey();
            Console.Clear();
        }

        static void ListSales()
        {
            saleManager.ListAllSales();
        }
    }
}
