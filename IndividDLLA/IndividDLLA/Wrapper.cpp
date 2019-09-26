#include "Wrapper.h"

SaveLoad sl;

void saveFile(float x, float y, float z) {

    return sl.saveFile(x, y, z);
}

char loadFile() {

    return sl.loadFile();
}