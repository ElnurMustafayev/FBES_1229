#pragma once

class Object {
protected:
    int width;
    int height;
    sf::Vector2f position;

public:
    sf::Texture* texture;
    sf::Sprite sprite;
    sf::IntRect currentRect;
    float scale = 1;

    Object(sf::Texture* texture, int width, int height, float scale = 1) {
        this->width = width;
        this->height = height;

        this->texture = texture;

        this->currentRect.height = this->height;
        this->currentRect.width = this->width;

        this->sprite = sf::Sprite(*this->texture, this->currentRect);
        this->scale = scale;

        this->sprite.setScale(this->scale, this->scale);
    }
};