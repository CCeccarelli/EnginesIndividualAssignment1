#include "Wrapper.h"

SaveLoad sl;

void saveFile(float x, float y, float z) {

    return sl.saveFile(x, y, z);
}

string loadFile() {

    return sl.loadFile();
}