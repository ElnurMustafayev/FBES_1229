#include <iostream>
#include <SFML/Graphics.hpp>
#include <windows.h>

using namespace std;

int main()
{
    sf::VideoMode viewMode = sf::VideoMode(500, 500);
    sf::RenderWindow window(viewMode, "SFML Getting started!");

    sf::Shape* shape = new sf::CircleShape (100.f);

    shape->setPosition(100, 100);

    sf::Event event = sf::Event();
    while (window.isOpen())
    {
        while (window.pollEvent(event)) {
            if (event.type == sf::Event::Closed) {
                window.close();
            }
        }

        window.clear(sf::Color::Magenta);

        shape->setFillColor(sf::Color::Color(100, 0, 200));

        window.draw(*shape);
        window.display();
    }
}