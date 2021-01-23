#include <iostream>
#include <queue>
#include <math.h>

using namespace std;

int main()
{
    queue<int> q;
    for (int i = 1; i <= 5; i++)
        q.push(i);
    q.pop();
    while (!q.empty())
    {
        cout << q.front() << " ";
        q.pop();
    }
    return 0;
}
//! ->"2 3 4 5 "