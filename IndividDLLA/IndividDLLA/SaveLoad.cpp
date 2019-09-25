#include "SaveLoad.h"

void SaveLoad::saveFile(float x, float y, float z) {
    myfile.open("pos.txt");
    
    myfile << to_string(x) + "," + to_string(y) + "," + to_string(z);

    myfile.close();
}

string SaveLoad::loadFile() {

    lfile.open("pos.txt");
    string line;

    if (lfile.is_open()) {
        while (getline(lfile, line)) {

        }

    }
    
    lfile.close();

    return line;
}