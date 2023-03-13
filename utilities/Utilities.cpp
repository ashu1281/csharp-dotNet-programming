#include "Utilities.h"

EXPIMP int* GetSampleData(size_t size) {
	int* pdata = new int[size];
	for (size_t i = 0; i < size; i++) {
		pdata[i] = static_cast<int>(i);

	}
	return pdata;
}

EXPIMP void FreeSampleData(int* pdata) {
	delete[] pdata;
	pdata = nullptr;
}