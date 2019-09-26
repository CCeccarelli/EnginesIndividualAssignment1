#pragma once

#include "PluginSettings.h"
#include "SaveLoad.h"

#ifdef __cplusplus
extern "C"
{
#endif

    PLUGIN_API void saveFile(float x, float y, float z);

    PLUGIN_API char loadFile();

#ifdef __cplusplus
}
#endif