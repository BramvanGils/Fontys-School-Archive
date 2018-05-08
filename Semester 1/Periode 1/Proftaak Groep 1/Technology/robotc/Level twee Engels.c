/*
This will house all the subject, level, question detail

subjects

ENGELS, NEDERLANDS, REKENEN

LEVELS

LEVELONE, LEVELTWO
...,      LEVELTEN

10 questions per level

[levelone][0]"___ "Coca Cola" an American Company"
[levelone][1]".."
[levelone][2]..

[leveltwo][0] ".."
..

3 answers per question

[questionone] {"Are", "Is", "The"}
*/

/*
3* 10 + 10 = 40
300 vragen
(3 * 10 + 10) * 3 = 120 antwoorden

string questionsRightAnswer[120];

3* 10 * 10 = 300
300 juiste vragen

string questionsRightAnswer[40];

10 * subject + level 3
*/

//[Subject][Level][Question]

// english test answers http://www.englishjet.com/english_courses_files/test_level_answers.asp

string questions[30] =
{
	"___ \"Coca Cola\" an American Company",// level one
	"I haven't got &&",
	"George..... fly to Stockholm tomorrow.",
	"I have Flamenco classes &&",
	"We have to go to the supermarket ..... some bread and milk.",
	"The party was a disaster. There ..... there!",
	"I ve lost my passport. I can t find it .....",
	"Every year,he goes to the coast for his holidays ....",
	"Which pen do you want?",
	"Mark ..... fly to London tomorrow.", // end level one

	"I ..... got a clue what you're talking about"., // level two
	"..... the key, we can't get inside.",
	"Is that ..... sister at the bar?",
	"Who is that, ..... that red coat?",
	"I go to church ..... Sunday.",
	"We ..... the summet and had to wait to be rescued.",
	"My character ..... up, he got stringer!",
	"The president was shot ..... visiting the theatre.",
	"I couldn't concentrate he was distracting me the ..... time!",
	"I don't ..... understand what you're trying to say.",

	"", // level three
	"",
	"",
	"",
	"",
	"",
	"",
	"",
	"",
	"",
};

// subject * level * question
// 0 * 0 * + 1
string questionsAnswers[30][3] = {
	{"Are", "Is", "The"}, // level one
	{"no brothers or sisters", "brothers or sisters", "any brothers or sisters"},
	{"to going", "goes to", "is going to"},
	{"on Saturday afternoons", "in Saturday afternoons", "at Saturday afternoons"},
	{"for getting", "to get", "to getting"},
	{"wasn t nobody", "was anybody", "was nobody"},
	{"anywhere.", "nowhere.", "everywhere."},
	{"in train", "on train", "by train"},
	{"A one blue", "One blue", "The blue one."},
	{"to going", "goes to", "is going to"}, //end level one

	{"Don't have", "Haven't", "Has"}, // level two
	{"With", "Within", "Without"},
	{"You're", "Your", "You"},
	{"Wearing", "Wears", "Worn"},
	{"Always", "Every", "On all"},
	{"Got stuck on", "Trapped on", "Reached at"},
	{"Levels", "Leveled", "Level"},
	{"Throughout", "During", "While"},
	{"Entire", "Complete", "All"},
	{"Surely", "Certainly", "Completely"}, // end level two

	{"", "", ""}, // level three
	{"", "", ""},
	{"", "", ""},
	{"", "", ""},
	{"", "", ""},
	{"", "", ""},
	{"", "", ""},
	{"", "", ""},
	{"", "", ""},
	{"", "", ""}, // end level three
};

string questionsRightAnswer[30] = {
	"Is", // level one
	"",
	"",
	"",
	"",
	"",
	"",
	"",
	"",
	"", // en level two

	"Haven't", // level two
	"Without",
	"Your",
	"Wearing",
	"Every",
	"Got stuck on",
	"Leveled",
	"While visiting",
	"Entire",
	"Completely", // en level one

	"Is", // level three
	"",
	"",
	"",
	"",
	"",
	"",
	"",
	"",
	"", // en level three
};
* WinGup v4.2
