#include "std_lib_facilities.h"

/*
Forest H.
Write a program that checks if a sentence is correct according to the “English” grammar in
§6.4.1. Assume that every sentence is terminated by a full stop (.) surrounded by whitespace.
For example, birds fly but the fish swim . is a sentence, but birds fly but the fish swim
(terminating dot missing) and birds fly but the fish swim. (no space before dot) are not. For
each sentence entered, the program should simply respond “OK” or “not OK.” Hint: Don’t
bother with tokens; just read into a string using >>.

Didnt get it to work quite right :(
 */

vector<string> nouns;
vector<string> verbs;
vector<string> conjunctions;

void init()
// initialize word classes
{
	nouns.push_back("birds");
	nouns.push_back("fish");
	nouns.push_back("C++");	// I didn't suggest addin "C+" to this exercise
							// but it seems some people like that

	verbs.push_back("rules");
	verbs.push_back("fly");
	verbs.push_back("swim");

	conjunctions.push_back("and");
	conjunctions.push_back("or");
	conjunctions.push_back("but");
}

bool is_noun(string w)
{
	for (int i = 0; i<nouns.size(); ++i)
		if (w == nouns[i]) return true;
	return false;
}

bool is_verb(string w)
{
	for (int i = 0; i<verbs.size(); ++i)
		if (w == verbs[i]) return true;
	return false;
}

bool is_conjunction(string w)
{
	for (int i = 0; i<conjunctions.size(); ++i)
		if (w == conjunctions[i]) return true;
	return false;
}

bool sentence()
{
	string w;
	cin >> w;
	if (!is_noun(w)) return false;

	string w2;
	cin >> w2;
	if (!is_verb(w2)) return false;

	string w3;
	cin >> w3;
	if (w3 == ".") return true;	// end of sentence
	if (!is_conjunction(w3)) return false;	// not end of sentence and not conjunction
	return sentence();	// look for another sentence
}

int main()
try
{
	cout << "enter a sentence of the simplified grammar (terminated by a dot):\n";

	init();	// initialize word tables

	while (cin) {
		bool b = sentence();
		if (b)
			cout << "OK\n";
		else
			cout << "not OK\n";
		cout << "Try again: ";
	}

	keep_window_open("~");	// For some Windows(tm) setups
}
catch (runtime_error e) {	// this code is to produceerror messages; it will be described in Chapter 5
	cout << e.what() << '\n';
	keep_window_open("~");	// For some Windows(tm) setups
}