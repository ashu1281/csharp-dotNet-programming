#pragma once
#if defined(UTILITIES_EXPORTS)
#define EXPIMP _declspec(dllexport)
#else
#define EXPIMP _declspec(dllimport)
#endif

extern "C" {
	EXPIMP int* GetSampleData(size_t size);
	EXPIMP void FreeSampleData(int* pdata);
}