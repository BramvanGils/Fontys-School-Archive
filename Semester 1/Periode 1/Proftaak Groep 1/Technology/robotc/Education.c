//TODO education array
/*

EducationArray
-LevelMath
-LevelOne
- bool finished
- int numberOfTimesFinished
- Lootbox lootbox struct
-LevelTwo
-LevelThree
-LevelDutch
-LevelOne
-LevelTwo
-LevelThree
-LevelEnglish
-LevelOne
-LevelTwo
-LevelThree

*/
enum Lootbox {
	COMMON,
	RARE,
	EPIC,
	LEGENDARY
};

struct SubjectDetails {
	bool finished;
	int numberOfTimesFinished;
	Lootbox lootbox;
};
