#include <SFML/Graphics.hpp>
#include <windows.h>

int main()
{
    sf::VideoMode viewMode = sf::VideoMode(500, 500);

    sf::RenderWindow window(viewMode, "It is title!");

    while (window.isOpen())
    {
        window.close();
    }
}