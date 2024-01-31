/*
    Recupera el número de repeticiones para cada caracter en una cadena de texto y lo muestra por consola.
*/

using System.Security.Cryptography.X509Certificates;

string message = "Frase de muestra";
char[] charsInMessage = message.ToCharArray();

foreach(char letter in charsInMessage.AsEnumerable().Distinct()){
    int countOfLetter = charsInMessage.Where(x=>Char.ToUpper(x).Equals(Char.ToUpper(letter))).Count();
    Console.WriteLine(String.Format("[{0}] appears [{1}] times in [{2}]", letter, countOfLetter, message));
}