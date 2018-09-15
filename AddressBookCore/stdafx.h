// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently
//

#pragma once

#include "targetver.h"

#define WIN32_LEAN_AND_MEAN             // Exclude rarely-used stuff from Windows headers
// Windows Header Files:
#include <windows.h>
#include <atlstr.h>
#include "TConvert.h"

#ifdef ADDRESSBOOKCORE_EXPORTS
#define DLL_EXPORT_ROADCORE __declspec(dllexport)
#else
#define DLL_EXPORT_ROADCORE __declspec(dllimport)  
#endif

// TODO: reference additional headers your program requires here
#pragma comment(lib, "libprotobuf.lib")
#pragma comment(lib, "libprotobuf-lite.lib")

/** return full path to this DLL
*/
CString getModulePath();


