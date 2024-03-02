using Telegram.Bot;
using Telegram.Bot.Types;

internal class Program
{
    private static void Main(string[] args)
    {
        // Add Comment
        var botClient = new TelegramBotClient("7090445360:AAG0dIyE55BrG7jIz5f83a1soox4waHnlYU");

        botClient.StartReceiving(Update, Error);

        Console.ReadLine();
    }

    private static async Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
    {
        var message = update.Message;

        await botClient.SendTextMessageAsync(message.Chat.Id, "Hello");

        return;
    }

    private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}