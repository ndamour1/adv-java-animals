namespace adv_java_animals
{
    public class Creater
    {
        public Talkable CreateTalkable()
        {
            // Variables
            string speciesInput = "";
            string nameInput = "";
            int ageInput = 0;
            int miceKilledInput = 0;
            bool isFriendlyInput = true;

            // Beginning instruction
            Console.WriteLine("Create an animal.\n");

            // Species input
            while (true)
            {
                Console.WriteLine("· Cat");
                Console.WriteLine("· Dog");
                Console.WriteLine("· Teacher");
                Console.WriteLine("Name which species of animal it is.");

                try
                {
                    string species = Console.ReadLine().ToLower().ToString();

                    switch (species)
                    {
                        case "cat":
                            break;
                        case "dog":
                            break;
                        case "teacher":
                            break;
                        default:
                            Console.WriteLine("Input invalid. Please choose in animal from the list.");
                            break;
                    }

                    if (species.Equals("cat") || species.Equals("dog") || species.Equals("teacher"))
                    {
                        speciesInput = species;
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            // Name input
            while (true)
            {
                Console.WriteLine("Enter the animal's name.");

                try
                {
                    string name = Console.ReadLine().ToString();

                    switch (name)
                    {
                        case "":
                            Console.WriteLine("Input invalid. Please enter a name.");
                            break;
                        case null:
                            Console.WriteLine("Input invalid. Please enter a name.");
                            break;
                        default:
                            break;
                    }

                    if (!name.Equals("") || !(name == null))
                    {
                        nameInput = name;
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            // Final input
            if (speciesInput.Equals("cat"))
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter the number of mice this cat has killed.");
                        int miceKilled = Convert.ToInt32(Console.ReadLine());

                        if (miceKilled >= 0)
                        {
                            miceKilledInput = miceKilled;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a positive integer.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
            else if (speciesInput.Equals("dog"))
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Is this dog friendly? Yes or no?");
                        string isFriendly = Console.ReadLine().ToLower().ToString();

                        switch (isFriendly)
                        {
                            case "yes":
                                isFriendlyInput = true;
                                break;
                            case "no":
                                isFriendlyInput = false;
                                break;
                            default:
                                Console.WriteLine("Input invalid. Please enter yes or no.");
                                break;
                        }

                        if (isFriendly.Equals("yes") || isFriendly.Equals("no"))
                        {
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
            else if (speciesInput.Equals("teacher"))
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter the teacher's age.");
                        int age = Convert.ToInt32(Console.ReadLine());

                        if (age >= 0)
                        {
                            ageInput = age;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a positive integer.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }

            // Object creatioon
            if (speciesInput.Equals("cat"))
            {
                return new Cat(miceKilledInput, nameInput);
            }
            else if (speciesInput.Equals("dog"))
            {
                return new Dog(isFriendlyInput, nameInput);
            }
            else if (speciesInput.Equals("teacher"))
            {
                return new Teacher(ageInput, nameInput);
            }
            else
            {
                Console.WriteLine("There was a problem with creating the object desired. Uploading default.");
                return new Teacher(36, "Curt Connors");
            }
        }
    }
}
