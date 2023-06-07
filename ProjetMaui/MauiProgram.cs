namespace ProjetMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseSentry(options =>
			{
				// TODO: Set the Sentry Dsn
				options.Dsn = "https://examplePublicKey@o0.ingest.sentry.io/0";
			})
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("FontAwesome6FreeBrands.otf", "FontAwesomeBrands");
				fonts.AddFont("FontAwesome6FreeRegular.otf", "FontAwesomeRegular");
				fonts.AddFont("FontAwesome6FreeSolid.otf", "FontAwesomeSolid");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddTransient<ArticleDataService>();
		builder.Services.AddTransient<ArticleDetailViewModel>();
		builder.Services.AddTransient<ArticleDetailPage>();

		builder.Services.AddSingleton<ArticleViewModel>();

		builder.Services.AddSingleton<ArticlePage>();

		builder.Services.AddTransient<CommentDataService>();
		builder.Services.AddTransient<CommentDetailViewModel>();
		builder.Services.AddTransient<CommentDetailPage>();

		builder.Services.AddSingleton<CommentViewModel>();

		builder.Services.AddSingleton<CommentPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<NotificationDetailViewModel>();
		builder.Services.AddTransient<NotificationDetailPage>();

		builder.Services.AddSingleton<NotificationViewModel>();

		builder.Services.AddSingleton<NotificationPage>();

		builder.Services.AddTransient<ConferenceDataService>();
		builder.Services.AddTransient<ConferenceDetailViewModel>();
		builder.Services.AddTransient<ConferenceDetailPage>();

		builder.Services.AddSingleton<ConferenceViewModel>();

		builder.Services.AddSingleton<ConferencePage>();

		builder.Services.AddSingleton<ConferenceDoneViewModel>();

		builder.Services.AddSingleton<ConferenceDonePage>();

		builder.Services.AddSingleton<AddArticleViewModel>();

		builder.Services.AddSingleton<AddArticlePage>();

		builder.Services.AddSingleton<AddConferenceViewModel>();

		builder.Services.AddSingleton<AddConferencePage>();

		builder.Services.AddSingleton<AuthorViewModel>();

		builder.Services.AddSingleton<AuthorPage>();

		builder.Services.AddSingleton<LogoutViewModel>();

		builder.Services.AddSingleton<LogoutPage>();

		builder.Services.AddSingleton<ProfileViewModel>();

		builder.Services.AddSingleton<ProfilePage>();

		builder.Services.AddSingleton<ProofReaderViewModel>();

		builder.Services.AddSingleton<ProofReaderPage>();

		builder.Services.AddSingleton<SettingsViewModel>();

		builder.Services.AddSingleton<SettingsPage>();

		builder.Services.AddSingleton<AddCommentViewModel>();

		builder.Services.AddSingleton<AddCommentPage>();

		builder.Services.AddSingleton<AffectProofReaderViewModel>();

		builder.Services.AddSingleton<AffectProofReaderPage>();

		builder.Services.AddSingleton<UpdateConferencesViewModel>();

		builder.Services.AddSingleton<UpdateConferencesPage>();

		builder.Services.AddSingleton<UpdateCommentsViewModel>();

		builder.Services.AddSingleton<UpdateCommentsPage>();

		builder.Services.AddSingleton<UpdateArticlesViewModel>();

		builder.Services.AddSingleton<UpdateArticlesPage>();

		// TODO: Add App Center secrets
		AppCenter.Start(
			"windowsdesktop={Your Windows App secret here};" +
			"android={Your Android App secret here};" +
			"ios={Your iOS App secret here};" +
			"macos={Your macOS App secret here};",
			typeof(Analytics), typeof(Crashes));

		return builder.Build();
	}
}
