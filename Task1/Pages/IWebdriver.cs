using OpenQA.Selenium;

namespace Task1
{
    public interface IWebdriver
    {
        object FindElement(By by);
    }
}