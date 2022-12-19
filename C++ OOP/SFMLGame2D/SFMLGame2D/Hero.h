#pragma once

#include <SFML/Graphics.hpp>
#include <iostream>
#include "Object.h"

using namespace std;


enum HeroState {
    stay = 0,
    down = 4,
    left,
    up,
    right,
};



class Hero : public Object {
public:
    int currentAnimationCount;
    int currentAnimationCounter = 0;
    string name = "Unknown";
    double speed = 10;
    HeroState state = HeroState::stay;

    Hero(sf::Texture* texture, int width, int height, float scale = 1);

    void SetState(HeroState state);
    void SetPosition(sf::Vector2f position);
    void SetPosition(float posX, float posY);
    
    void Go(bool shift);
    void UpdateAnimation() {
        this->currentRect.left = (this->currentAnimationCounter++ % this->currentAnimationCount) * this->width;

        this->sprite.setTextureRect(this->currentRect);
    }
};