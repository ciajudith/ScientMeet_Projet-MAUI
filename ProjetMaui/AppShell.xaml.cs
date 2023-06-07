namespace ProjetMaui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ConferenceDetailPage), typeof(ConferenceDetailPage));
		Routing.RegisterRoute(nameof(NotificationDetailPage), typeof(NotificationDetailPage));
		Routing.RegisterRoute(nameof(CommentDetailPage), typeof(CommentDetailPage));
		Routing.RegisterRoute(nameof(ArticleDetailPage), typeof(ArticleDetailPage));
	}
}
