#include <SFML/Graphics.hpp>
#include <iostream>

using namespace std;

int main1()
{
    srand(time(0));

    const float wWidth = 800;
    const float wHeight = 800;

    sf::RenderWindow window(sf::VideoMode(wWidth, wHeight), "2D Game");

    const float radius = 50;

    //sf::Shape* shape = new sf::RectangleShape(sf::Vector2f(100, 50));
    sf::Shape* shape = new sf::CircleShape(radius);

    sf::Vector2f pos = sf::Vector2f(rand() % (int)wWidth, rand() % (int)wHeight);

    shape->setOrigin(radius, radius);
    shape->setPosition(pos);
    shape->setOutlineThickness(5);
    
    int blue = 0;
    int red = 100;
    int green = 200;

    float speed = 0.1;

    float speedX = speed;
    float speedY = speed;

    while (window.isOpen())
    {
        // - - - - - - - - - - - - - - - - - - EVENTS - - - - - - - - - - - - - - - - - -
        sf::Event event;
        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                window.close();


            if (event.type == sf::Event::MouseButtonPressed && event.mouseButton.button == sf::Mouse::Left) {
                if ((pos.x - radius <= event.mouseButton.x && pos.x + radius >= event.mouseButton.x) &&
                    (pos.y - radius <= event.mouseButton.y && pos.y + radius >= event.mouseButton.y)) {
                    cout << "OK!" << endl;
                }
                else {
                    cout << "NOT OK!" << endl;
                }
            }
        }





        // - - - - - - - - - - - - - - - - - - LOGIC - - - - - - - - - - - - - - - - - -
        if (pos.x - radius <= 0) {
            speedX = speed;
            speed += 0.1;
        }
        else if (pos.x + radius >= wWidth) {
            speedX = - (speed);
            speed += 0.1;
        }

        if (pos.y - radius <= 0) {
            speedY = speed;
            speed += 0.1;
        }
        else if (pos.y + radius >= wHeight) {
            speedY = - (speed);
            speed += 0.1;
        }

        pos.x += speedX;
        pos.y += speedY;

        shape->setPosition(pos);

        shape->rotate(0.1);
        shape->setFillColor(sf::Color::Color(red++, green++, blue++));
        shape->setOutlineColor(sf::Color::Color(rand(), rand(), rand()));






        // - - - - - - - - - - - - - - - - - - DRAW - - - - - - - - - - - - - - - - - -
        window.clear(sf::Color::Yellow);
        window.draw(*shape);
        window.display();
    }

    return 0;
}