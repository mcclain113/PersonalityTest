namespace PersonalityTest;

public partial class PageSwipe : ContentPage
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
    public PageSwipe()
    {
        InitializeComponent();
        Question.Text = questions[questionNumber];
    }

    void SwipeGestureRecognizer_Left(object sender, SwipedEventArgs e)
    {
       if (counter >4){}
       else
       {
           Score++;
           questionNumber++;
           counter++;

           Question.Text = questions[questionNumber];
           ImageSwipe.Source = images[questionNumber];
       }

       if (counter > 4 )
        {

            if (Score == 4)
            {
                Question.Text = "Congrats!";
                ImageSwipe.Source = images[5];
            }
            else
            {
                Question.Text = "Keep trying.";
            }
            
        }
    }
    
    void SwipeGestureRecognizer_Right(object sender, SwipedEventArgs e)
    {
        if (counter >4){}
        else
        {
            questionNumber++;
            counter++;

            Question.Text = questions[questionNumber];
            ImageSwipe.Source = images[questionNumber];
        }

        if (counter > 4 )
        {

            if (Score == 4)
            {
                Question.Text = "Congrats!";
                ImageSwipe.Source = images[5];
            }
            else
            {
                Question.Text = "Keep trying.";
            }


        }
    }

    async void OnButtonClicked(object sender, EventArgs args)
    {
        await Navigation.PushAsync(new MainPage(), true);
    }

    private void Refresh_Clicked(object? sender, EventArgs e)
    {
        counter = 1;
        Score = 0;
        questionNumber = 0;
        Question.Text = questions[questionNumber];
        ImageSwipe.Source = "spider_man.png";
    }
}