using System;

namespace MovieKillerDesktopApp.Models
{
    public class ReceivedDataDecoder
    {
        public string DecodeMessage(string valueToReturn, string dataToDecode)
        {
            const char delimiter = ',';

            var decodedData = dataToDecode.Split(delimiter);

            var command = decodedData[0];

            switch(valueToReturn)
            {
                case "Command":
                    return command;
                case "Time":
                    try
                    {
                        var timeToStart = decodedData[1];
                        return timeToStart;
                    }
                    catch(Exception)
                    {
                        return "Błąd wiadomości";
                    }
                case "Speed":
                    try
                    {
                        var levelOfSpeed = decodedData[1];
                        return levelOfSpeed;
                    }
                    catch(Exception)
                    {
                        return "Błąd wiadomości";
                    }
            }
            return "Błąd wiadomości";
        }
        public string DecodeCommand(string command)
        {
            switch(command)
            {
                case "U":
                    command = "Uśpij";
                    break;
                case "W":
                    command = "Wyłącz";
                    break;
                case "R":
                    command = "Zrestartuj";
                    break;
                case "L":
                    command = "Zablokuj";
                    break;
                case "LO":
                    command = "Wyloguj";
                    break;
                case "Budzik":
                    command = "Budzik";
                    break;
                case "Stop":
                    command = "Zastopuj operacje z polecenia kontrolera";
                    break;
                case "Speed":
                    command = "Zmiana prędkości zegara";
                    break;
                case "Błąd wiadomości":
                    command = "Błąd wiadomości";
                    break;
                case "Koniec":
                    command = "Koniec";
                    break;
                default:
                    command = "Błąd wiadomości";
                    break;
            }
            return command;
        }
    }
}
