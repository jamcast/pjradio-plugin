/*-
 * Copyright (c) 2015 Software Development Solutions, Inc.
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions
 * are met:
 * 1. Redistributions of source code must retain the above copyright
 *    notice, this list of conditions and the following disclaimer.
 * 2. Redistributions in binary form must reproduce the above copyright
 *    notice, this list of conditions and the following disclaimer in the
 *    documentation and/or other materials provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY THE AUTHOR AND CONTRIBUTORS ``AS IS'' AND
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED.  IN NO EVENT SHALL THE AUTHOR OR CONTRIBUTORS BE LIABLE
 * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS
 * OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
 * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT
 * LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY
 * OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF
 * SUCH DAMAGE.
 */

using Jamcast.Extensibility.ContentDirectory;
using Jamcast.Extensibility.Metadata;

namespace Jamcast.Plugins.PearlJamRadio
{
    public class PJRTrack : ObjectRenderer
    {
        public override ServerObject GetMetadata()
        {
            // this is the radio stream metadata, we set what information we have
            // and return it

            AudioItem track = new AudioItem(new UriLocation("http://radio.nugs.net:8080"), MediaFormats.MP3);
            track.MediaType = AudioMediaType.Radio;
            track.Title = "Pearl Jam Radio";
            track.Genre = "Rock";
            track.AlbumArtist = "Pearl Jam";
            track.Artists.Add("Pearl Jam");
            track.Album = "Various";
            track.AlbumArt = new ImageResource(
                new MediaServerLocation(
                    typeof(AlbumArtHandler),
                    null),
                MediaFormats.PNG
                );

            return track;
        }
    }
}