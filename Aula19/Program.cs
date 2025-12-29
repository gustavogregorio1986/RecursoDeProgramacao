namespace Aula19
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\RecursoDeProgramação\\Aula19";
            string fileName = "Lista_de_Compras.txt";
            string fullPath = path + fileName;

            List<string> shoppingList = new List<string>();

            //Lógica
            if(File.Exists(fileName))
            {
                shoppingList.AddRange(File.ReadAllLines(fullPath));
            } 

            while(true)
            {
                Console.WriteLine("\n== Lista de Compras ===");
                Console.WriteLine("1. Adicionar item");
                Console.WriteLine("2. Remover item");
                Console.WriteLine("3. Exibir lista");
                Console.WriteLine("4. Sair");

                string choiceUser = Console.ReadLine();

                switch (choiceUser)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do item para adicionar: ");
                        string itemInsert = Console.ReadLine();
                        // var test = string.Empty;
                        if (!string.IsNullOrEmpty(itemInsert))
                        {
                            shoppingList.Add(itemInsert);
                            Console.WriteLine($"Item {itemInsert} adicionado com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("O  item não pode ser vazio!");
                        }
                      break;
                      case "2":
                        Console.WriteLine("Digite o nome do item para remover: ");
                        string itemRemove = Console.ReadLine();
                        if (shoppingList.Remove(itemRemove))
                        {
                            Console.WriteLine($"Item {itemRemove} removido com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine($"Item {itemRemove} não encontrado na lista.");
                        }
                        
                        
                      break;

                      case "3":
                        Console.WriteLine("\n Item na sua lista de compras");
                        if (shoppingList.Count == 0)
                        {
                            Console.WriteLine("Sua lista de compras está vazia.");
                        }
                        else
                        {
                            for (int i = 0; i < shoppingList.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {shoppingList[i]}");
                            }
                        }
                        break;

                        case "4":
                        //Salvar a lista em um arquivo antes de sair
                        File.WriteAllLines(fullPath, shoppingList);
                        Console.WriteLine("Lista salva coms ucesso! saindo...");
                        return;
                        default:
                         Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }


            }
         }
     }
}
