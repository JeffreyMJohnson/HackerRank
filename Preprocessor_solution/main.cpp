/* Enter your macros here */
#define toStr(a) #a
#define io(a) cin >> a
#define foreach(a,b) for(int b = 0; b < a.size(); ++b)
#define FUNCTION(a,b) 
#define INF INT_MAX
#define minimum(a,b) a = a < b ? a : b
#define maximum(a,b) a = a > b ? a : b
#include <limits>


#include <iostream>
#include <vector>

using namespace std;

#if !defined toStr || !defined io || !defined FUNCTION || !defined INF
#error Missing preprocessor definitions
#endif 

FUNCTION(minimum, < )
	FUNCTION(maximum, > )

int main() {
	int n; cin >> n;
	vector<int> v(n);
	foreach(v, i) {
		io(v)[i];
	}
	int mn = INF;
	int mx = -INF;
	foreach(v, i) {
		minimum(mn, v[i]);
		maximum(mx, v[i]);
	}
	int ans = mx - mn;
	cout << toStr(Result = ) << ' ' << ans;
	return 0;

}