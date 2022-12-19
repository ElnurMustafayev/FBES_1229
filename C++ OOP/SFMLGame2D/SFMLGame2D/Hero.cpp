#include "Hero.h"

Hero::Hero(sf::Texture* texture, int width, int height, float scale) : Object(texture, width, height, scale) {
    this->currentAnimationCount = 3;
    this->currentRect = sf::IntRect(
        this->currentAnimationCounter * this->width,
        this->state * this->height, 
        this->width, 
        this->height
    );

    this->sprite = sf::Sprite(*this->texture, this->currentRect);
    this->sprite.setOrigin(this->width / 2, this->height / 2);

    this->scale = scale;
    this->sprite.setScale(this->scale, this->scale);

}









void Hero::SetState(HeroState state) {
    this->state = state;
    this->currentAnimationCount = state == HeroState::stay ? 3 : 10;


    if (state == HeroState::stay)
        this->currentAnimationCounter = 0;


    this->currentRect.top = this->height * state;
    this->currentRect.left = this->width * this->currentAnimationCounter;

    this->sprite.setTextureRect(this->currentRect);
}





void Hero::SetPosition(sf::Vector2f position) {
    this->position = position;
    this->sprite.setPosition(this->position);
}

void Hero::SetPosition(float posX, float posY) {
    this->position = sf::Vector2f(posX, posY);
    this->sprite.setPosition(this->position);
}


void Hero::Go(bool shift) {
    int resultSpeed = shift
        ? this->speed * 3
        : this->speed;


    switch (this->state)
    {
    case HeroState::down:
        SetPosition(this->position.x, this->position.y + resultSpeed);
        UpdateAnimation();
        break;
    case HeroState::left:
        SetPosition(this->position.x - resultSpeed, this->position.y);
        UpdateAnimation();
        break;
    case HeroState::up:
        SetPosition(this->position.x, this->position.y - resultSpeed);
        UpdateAnimation();
        break;
    case HeroState::right:
        SetPosition(this->position.x + resultSpeed, this->position.y);
        UpdateAnimation();
        break;

    case HeroState::stay:
    default:
        break;
    }
}
