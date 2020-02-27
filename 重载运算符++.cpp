#include <iostream>
using namespace std;

//递增运算符重载

class person
{
  friend ostream&  operator<<(ostream &c_out,const person &p);
    //前置++
    public:


        //返回引用是为了对同一个数据进行递增操作
    person& operator++()
    {
        b++;a++;
        return *this;
    }
  //后置++  后置递增返回不需要引用因为temp是局部的
    person operator++(int)//这里的int代表占位参数，可以区分前值和后置递增
  {
      person temp=*this;

      a++;
      b++;;
      return temp;
  }

private :
    int a=0;
    int b=2;
};

ostream&  operator<<(ostream &c_out,const person &p)//本质是 operator<<(cout,p)  cout<<p
{
   c_out<<"p.b"<<p.b<<endl;
   c_out<<"p.a "<<p.a;

    return c_out;//返回ostream&类型是为了调用运算符重载函数后可以继续连接其他内容
}
void test1()
{
   person p;
    cout<<++(++p)<<endl;
    cout<<p<<endl;
}
void test2()
{
  person p;
  cout<<p++<<endl;
  cout<<p<<endl;

}
int main()
{

    test1();
    test2();
    return 0;
}
