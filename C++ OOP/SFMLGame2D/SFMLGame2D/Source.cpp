#include <SFML/Graphics.hpp>
#include <iostream>

using namespace std;

int main()
{
    const float wWidth = 800;
    const float wHeight = 800;

    sf::RenderWindow window(sf::VideoMode(wWidth, wHeight), "2D Game");





    sf::Texture heroTexture = sf::Texture();
    heroTexture.loadFromFile("Assets\\hero.png");


    double spriteCounter = 0;
    const int animationsCount = 10;

    int heroHeight = 41;
    int heroWidth = 38;

    int heroAnimationY = 7;

    sf::Sprite heroSprite = sf::Sprite(heroTexture);
    heroSprite.setOrigin(21, 18);
    heroSprite.setScale(5, 5);
    heroSprite.setTextureRect(sf::IntRect(heroWidth * spriteCounter, heroHeight * heroAnimationY, heroWidth, heroHeight));
    heroSprite.setPosition(wWidth / 2, wHeight / 2);



    while (window.isOpen())
    {
        // - - - - - - - - - - - - - - - - - - EVENTS - - - - - - - - - - - - - - - - - -
        sf::Event event;

        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                window.close();
        }

        spriteCounter += 0.05;
        heroSprite.setTextureRect(sf::IntRect(heroWidth * ((int)spriteCounter % animationsCount), heroHeight * heroAnimationY, heroWidth, heroHeight));
       
        heroSprite.setPosition(heroSprite.getPosition().x + 0.1, heroSprite.getPosition().y);

        window.clear(sf::Color::Green);
        window.draw(heroSprite);
        window.display();
    }


    return 0;
}