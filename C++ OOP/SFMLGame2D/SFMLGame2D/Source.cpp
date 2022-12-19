#include <SFML/Graphics.hpp>
#include <iostream>
using namespace std;


sf::Texture heroTexture = sf::Texture();
sf::Texture grassTexture = sf::Texture();

#include "Hero.h"


int main()
{
    srand(time(0));

    // - - - - - LOAD - - - - - 
    heroTexture.loadFromFile("Assets\\hero.png");
    grassTexture.loadFromFile("Assets\\grass.png");

    const float wWidth = 800;
    const float wHeight = 800;
    sf::RenderWindow window(sf::VideoMode(wWidth, wHeight), "2D Game");

    Hero hero = Hero(&heroTexture, 38, 41, 3);
    Object grass = Object(&grassTexture, wWidth, wHeight, (wWidth / 500));

    hero.SetPosition(sf::Vector2f(400, 400));

    while (window.isOpen())
    {
        // - - - - - - - - - - - - - - - - - - EVENTS - - - - - - - - - - - - - - - - - -
        sf::Event event;

        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                window.close();


            if (event.type == sf::Event::KeyPressed) {
                switch (event.key.code)
                {
                case sf::Keyboard::Key::Down:
                    hero.SetState(HeroState::down);
                    break;
                case sf::Keyboard::Key::Left:
                    hero.SetState(HeroState::left);
                    break;
                case sf::Keyboard::Key::Up:
                    hero.SetState(HeroState::up);
                    break;
                case sf::Keyboard::Key::Right:
                    hero.SetState(HeroState::right);
                    break;
                }

                hero.Go(event.key.shift);
            }

            if (event.type == sf::Event::KeyReleased) {
                hero.SetState(HeroState::stay);
            }
        }

        window.clear();
        window.draw(grass.sprite);
        window.draw(hero.sprite);
        window.display();
    }


    return 0;
}