#include "SaveLoad.h"

void SaveLoad::saveFile(float x, float y, float z) {
    myfile.open("pos.txt");
    
    myfile << to_string(x) + "," + to_string(y) + "," + to_string(z);

    myfile.close();
}

char SaveLoad::loadFile() {

    lfile.open("pos.txt");
    char line[99];
	string s(line);

    if (lfile.is_open()) {
        while (getline(lfile, s)) {

        }

    }
	s = line;
    
    lfile.close();
	return line[99];
}