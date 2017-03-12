#include <iostream>

int main()
{
	#if DebugConfig
	std::cout << "WE ARE IN THE DEBUG CONFIGURATION" << endl;
	#endif
	std::cout << "Hello World!" << endl;
	
	return 0;
}