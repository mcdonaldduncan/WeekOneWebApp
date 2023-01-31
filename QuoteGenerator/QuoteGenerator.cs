using System.Xml.Linq;

namespace WeekOneWebApp.QuoteGenerator
{
    public class QuoteGenerator
    {
        // quote array generated with ChatGPT,
        // sourced from two of my favorite books,
        // a few are actually from the books, most were made up by chatgpt,
        // two of my favorites that actually come from the book are entered 2-3 times to increase hitrate,
        static string[] quotes = new string[]
        {
            "“It's the questions we can't answer that teach us the most. They teach us how to think. If you give a man an answer, all he gains is a little fact. But give him a question and he'll look for his own answers.” - The Name of the Wind",
            "“There are three things all wise men fear: the sea in storm, a night with no moon, and the anger of a gentle man.” - The Name of the Wind",
            "“It's easy to forget what a treasure you have in your hands until it's gone.” - The Name of the Wind",
            "“Life is like a game of chess. To win you have to make a move. Knowing which move to make comes with insight, knowing all the possible moves comes with intelligence.” - A Wise Man's Fear",
            "“It's not what you take when you leave this world behind you. It's what you leave behind you when you go.” - A Wise Man's Fear",
            "“There are three things all wise men fear: the sea in storm, a night with no moon, and the anger of a gentle man. - The Wise Man's Fear",
            "“Stories are like money, Claire. Everyone wants them, but they don't always know the value of the coin they hold.” - A Wise Man's Fear",
            "“Music is a powerful thing. It can bring people together like nothing else can. It can take us to places we've never been.” - The Name of the Wind",
            "“If you only listen to what people tell you, you'll never learn anything new.” - The Name of the Wind",
            "“You can love someone with all your heart and still end up losing them.” - A Wise Man's Fear",
            "“There are three things all wise men fear: the sea in storm, a night with no moon, and the anger of a gentle man.” - The Name of the Wind",
            "“There are three things you need for a good story. A willing listener, a good tale, and enough wine to help it all go down.” - The Name of The Wind",
            "“Life is a story. It’s not just what happens to us, but what we make of what happens to us.” - The Name of The Wind",
            "“The best way to find out if you can trust somebody is to trust them.” - A Wise Man's Fear",
            "“It’s the small everyday deeds of ordinary folk that keep the darkness at bay.” - A Wise Man's Fear",
            "“There are only two things we can be sure of in this life. The first is that we will all die. The second is that we will all suffer for it.” - A Wise Man's Fear",
            "“It's the questions we can't answer that teach us the most. They teach us how to think. If you give a man an answer, all he gains is a little fact. But give him a question and he'll look for his own answers.” - The Name of the Wind",
            "“There are three things all wise men fear: the sea in storm, a night with no moon, and the anger of a gentle man.” - The Wise Man's Fear",
            "“A story is a way to say something that can't be said any other way.” - The Name of the Wind",
            "“It's the things you know that ain't so that get you into trouble.” - The Name of the Wind",
            "“It is not knowing that is hard. It is deciding what to do about what you know.” - The Name of the Wind",
            "“I have known many gods. He who denies them is as blind as he who trusts them too deeply. I seek not beyond death. It may be the blackness averted me, or perhaps it was a deeper fear. What is death, after all? Not the end, but merely a transition.” - The Wise Man's Fear",
            "“It's the things you don't expect that change your life.” - The Name of the Wind",
        };

        public static string GetRandomQuote()
        {
            Random rand = new Random();
            return quotes[rand.Next(quotes.Length)];
        }
    }
}
