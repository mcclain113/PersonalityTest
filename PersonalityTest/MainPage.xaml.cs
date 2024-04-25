namespace PersonalityTest;

public partial class MainPage
{

    string[] questions =
    {
        "Are you from the city?",
        "Do you enjoy heights?",
        "Have you been bitten by a radioactive spider?",
        "Do you like stopping crime?",
        " "

    };
    string[] images =
    {
        "city.png",
        "height.png",
        "spider.png",
        "crime.png",
        "sorry.png",
        "you_are_spider_man"

    };


    private int counter = 1;

    private int Score;
    private int questionNumber;
    

    public MainPage()
    {
        InitializeComponent();

        Question.Text = questions[questionNumber];

    }



    private void True_Clicked(object sender, EventArgs e)
    {
        Score++;
        questionNumber++;
        counter++;
        Question.Text = questions[questionNumber];
        Image.Source = images[questionNumber];

        if (counter > 4 )
        {
            True.IsVisible = false;
            False.IsVisible = false;

            if (Score == 4)
            {
                Question.Text = "Congrats!";
                Image.Source = images[5];
            }
            else
            {
                Question.Text = "Keep trying.";
            }

            
        }

    }

    private void False_Clicked(object sender, EventArgs e)
    {
        questionNumber++;
        counter++;

        Question.Text = questions[questionNumber];
        Image.Source = images[questionNumber];
        if (counter > 4 )
        {
            True.IsVisible = false;
            False.IsVisible = false;

            if (Score == 4)
            {
                Question.Text = "Congrats!";
                Image.Source = images[5];
            }
            else
            {
                Question.Text = "Keep trying.";
            }


        }
    }


    private void Refresh_Clicked(object? sender, EventArgs e)
    {
            counter = 1;
            True.IsVisible = true;
            False.IsVisible = true;
            Score = 0;
            questionNumber = 0;
            Question.Text = questions[questionNumber];
            Image.Source = "spider_man.png";
   
    }

    async void Swipe_Clicked(object? sender, EventArgs args)
    {
        await Navigation.PushAsync(new PageSwipe(), true);
    }
}