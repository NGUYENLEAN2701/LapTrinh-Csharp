#include <iostream>
using namespace std;
int main()
{
    int a[100];
    int n;
    cin >> n;
    for (int i = 0; i < n; i++)
    {
        cin >> a[i];
    }
    int k = 0;
    for (int i = 0; i < n; i++)
    {
        if (a[i] > a[k])
            k = i;
    }
    cout << k;
    return 0;
}
//!k dùng để lưu chỉ số của phần tử lớn nhất đầu tiên trong mảng a...