﻿namespace Application.Dtos.Tokens
{
    public class TokensReadDto
    {
        public Token AccessToken { get; set; }

        public Token RefreshToken { get; set; }
    }
}