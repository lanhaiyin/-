#include <iostream>
using namespace std;


class Rectangle
{
    public:
        Rectangle();                                //无参默认构造
        Rectangle(float width,float height);       //带参构造
        Rectangle(const Rectangle & rect);              //拷贝构造
        Rectangle(int width);                  //转换构造
        void print()
        {
            cout<<"width:"<<width<<endl;
            cout<<"height:"<<height<<endl;
        }
        virtual ~Rectangle();


    protected:

    private:
        float width;
        float height;
};


Rectangle::Rectangle():width(1.1),height(2.1)
{

}
Rectangle::Rectangle(float width,float height):width(width),height(height)
{

}
 Rectangle::Rectangle(const Rectangle & rect)
 {
      this->height=rect.height;
      this->width=rect.width;
 }
 Rectangle::Rectangle(int width):width(width),height(width)
{

}
Rectangle::~Rectangle()
{
    //dtor
}
int main()
{
    Rectangle rect1;  //调用默认构造
    Rectangle rect2(5.5,6.6);//调用带参构造
    Rectangle rect3(rect1);   //调用拷贝构造
    Rectangle rect4=66.6;  //等价于Rectangle rect4(66);调用一个参数的构造——转换构造
    rect3.print();
}
