// initialize variables - graded assignments 
int currentAssignments = 5;
//demonstrating a declaration of an array of integers to hold the scores for each student
int[] sophiaScores = new int[5];
//demonstrating a declaration  of an array of integers to hold the scores for each student
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

//The first group of variables are integers that are being used to hold the sum of the exam scores.

//The second group of variables are decimals that are used to hold the calculated average score.
//The code uses decimals here because an integer calculation rounds off the fractional portion of the calculated value.
int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

//The first group of equations is used to calculate the sum of the assignment scores for each student.
sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

//This section prints the formatted output in accordance with the teacher's guidelines
//The first line is a header line with column titles, followed by the names and scores for each student.

//The Console.ReadLine() statement pauses the application so that the application user can review the output.
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();