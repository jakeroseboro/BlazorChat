using BlazorChat.Shared;

namespace BlazorChat.Client;

public interface IChatManager
{
    Task<List<ApplicationUser>> GetUsersAsync();
    Task SaveMessageAsync(ChatMessage message);
    Task<List<ChatMessage>> GetConversationAsync(string contactId);
    Task<ApplicationUser> GetUserDetailsAsync(string userId);
}